using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Повышение_квалификации
{
    public class DbWorker
    {
        string _connectionString = null;

        /// <summary>
        /// Роли пользователей
        /// </summary>
        public enum Roles
        {
            Admin = 1,
            Teacher = 2,
            Metodist = 3,
            Kadrovik = 4
        }

        string sertificateQuery = @" 
                            select 
	                        U.firstName
	                        ,U.midleName
	                        ,U.lastName
	                        ,L.registrationNumber, 
	                        L.[startDate], 
	                        L.[endDate]
	                        ,c.coursName as 'Название курса'
	                        ,c.courseVolume as 'Объем курса'
	                        ,CT.coursName
	                        --,ET.educationType
                        from  Курсы as C
                        Left Join Обучение as L
                        on C.id = L.coursId
                        left Join ВидКурса CT
                        on CT.id = C.coursTypeId
                        left join ФормаОбучения as ET
                        on ET.id = C.educationFormId
                        left join (select T.id, U.firstName,U.midleName,U.lastName,U.roleId from Пользователи U 
			                        Left join Преподаватели T
			                        on t.userId = U.id
			
		                           ) as U
                        on U.id= L.teacherId
                        where L.id is not null
                        and U.roleId = (select id from Роли where roleName like '%преподаватель%')";


        private string authQuery = @"select a.*,r.roleName,r.id 
                                                from Пользователи u, Роли r, Авторизация a
                                                where u.authId = a.id
                                                and u.roleId = r.id
                                                and a.login = '{0}'
                                                and a.password = '{1}'
                                                and r.id= {2}; ";


        string registrQuery = @"begin
                                declare @id int;
                                declare @date datetime;
                                insert Авторизация(login,password)
                                values('{0}', '{1}');		
                                set @id = (SELECT SCOPE_IDENTITY());
                                set @date = (select CONVERT(datetime, '{5}', 103));
                                insert Пользователи(firstName,midleName,lastName,dateOfBirth,authId,roleId)
                                values('{2}','{3}','{4}',@date,@id,{6});        
                                end;";


        public DbWorker()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Courses"].ToString();
        }

        /// <summary>
        /// Возвращает результаты для формирования справки о курсах
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetSertificateData()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(sertificateQuery))
            {
                string name = "";
                string middleName = "";
                string lastName = "";
                string regNumber = "";
                string startDate = "";
                string endDate = "";
                string volume = "";
                string coursName = "";
                string coursType = "";

                con.Open();             
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        name = reader.GetValue(0).ToString();
                        middleName = reader.GetValue(1).ToString();
                        lastName = reader.GetValue(2).ToString();
                        regNumber = reader.GetValue(3).ToString();
                        startDate = reader.GetValue(4).ToString();
                        endDate = reader.GetValue(5).ToString();
                        coursName = reader.GetValue(6).ToString();
                        volume = reader.GetValue(7).ToString();
                        coursType = reader.GetValue(8).ToString();
                    }
                }
                reader.Close();
                con.Close();
                if (name.Length > 0)
                {
                    return new Dictionary<string, string>() {
                    {"FirstName",name },
                    { "MiddleName",middleName},
                    { "LastName", lastName},
                    { "RegisterNumber", regNumber},
                    { "StartDate", startDate},
                    { "EndDate", endDate},
                    { "CoursName", coursName},
                    { "Volume", volume},
                    { "CoursType", coursType}
                };
                }
            }
               
            return null;

        }

        /// <summary>
        /// Регистрация  пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="time"></param>
        /// <param name="role"></param>
        public int RegisterUser(string login, string password, string firstName,
                                  string middleName, string lastName, DateTime time, int role)
        {
            int results = -1;
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(registrQuery))
            {
                con.Open();
                registrQuery = string.Format(registrQuery, login, password, firstName,
                                             middleName, lastName, time.Date.ToString(),role);

                command.Connection = con;
                results = command.ExecuteNonQuery();
            }

            return results;
        }

        /// <summary>
        /// Получает данные пользователя из таблицы Авторизация 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetAnswer(string query)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query))
            {
                string login = "";
                string password = "";
                string role = "";
                con.Open();

                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        login = reader.GetValue(1).ToString();
                        password = reader.GetValue(2).ToString();
                        role = reader.GetValue(3).ToString();
                    }
                }
                reader.Close();
                con.Close();

                if (login.Length > 0)
                {
                    return new Dictionary<string, string>() {
                    {"login",login },
                    { "password",password},
                    { "role", role}
                };
                }
            }

            return null;
        }


        public bool IsExactUser(string login, string password, int role)
        {
            Dictionary<string, string> user = null;
            user = GetAnswer(string.Format(authQuery, login, password, role));
            return user != null;
        }


        public string GetAuthtorizationId(string login)
        {
            string query = @"select id from Авторизация where login = '{0}'";
            string id = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(string.Format(query, login)))
            {
                con.Open();
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        id = reader.GetValue(0).ToString();
                    }
                }
                reader.Close();
                con.Close();
            }

            return id;
        }
    }
}
