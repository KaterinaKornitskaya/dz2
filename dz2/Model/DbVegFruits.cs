using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dz2.Model
{
    internal class DbVegFruits : IDisposable
    {
        SqlConnection connection = null;

        public DbVegFruits()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbVegFruits"].ConnectionString;
           
            //connection.ConnectionString = @"Data Source=DESKTOP-7GU49OD\SQLEXPRESS;
            //                                Initial Catalog = FruitsVegetables;
            //                                Integrated Security = true;";
        }

        public void Dispose()
        {
            connection.Close();
        }

        // асинхронный метод для обновления
        public async void Update(string name, string color, double cal)
        {
            try
            {
                // здесь используем свойство Parameters, чтобы избежать попадания
                // через Update символов, которые могут нанести вред нашей БД
                connection.Open();
                string cmdText = @"update FruitsVegs set Color = @pcolor, Calory = @pcal where Name = @pname";
                SqlCommand cmd = connection.CreateCommand();
                cmd.Parameters.Add("@pcolor", SqlDbType.NVarChar).Value = color;
                cmd.Parameters.Add("@pcal", SqlDbType.Real).Value = cal;
                cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = name;
                cmd.CommandText = cmdText;
                await cmd.ExecuteNonQueryAsync();
            }
            finally { connection.Close(); }
        }

        // асинхронный метод для удаления
        public async void Delete(string name)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"delete from FruitsVegs where Name = '{name}'";
                await cmd.ExecuteNonQueryAsync();
            }
            finally
            {
                connection.Close();
            }
        }

        // отображение всех данных из таблицы
        public List<FruitsVegs> ShowAllInfo()
        {
            List<FruitsVegs> frVegList = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from FruitsVegs"; 
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    frVegList.Add(new FruitsVegs()
                    {
                        ID = (int)rd[0],
                        Name = (string)rd[1],
                        Type = (string)rd[2],
                        Color = (string)rd[3],
                        Calory = (float)rd[4],
                    });
                    
                }
                rd.Close(); 
            }
            finally
            {
                connection.Close();
            }
            return frVegList;
        }

        // Отображение всех названий овощей и фруктов;
        public List<FruitsVegs> ShowNames()
        {
            List<FruitsVegs> frVegList = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select Name from FruitsVegs order by Name";
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    frVegList.Add(new FruitsVegs()
                    {
                        Name = (string)rd[0]
                    });
                }
                rd.Close();
            }
            finally
            {
                connection.Close();
            }
            return frVegList;
        }

        // Отображение всех цветов;
        public List<FruitsVegs> ShowAllColors()
        {
            List<FruitsVegs> frList = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select Color from FruitsVegs group by Color";
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    frList.Add(new FruitsVegs()
                    {
                        Color = (string)rd[0]
                    });
                }
                rd.Close();
            }
            finally
            {
                connection.Close();
            }
            return frList;
        }

        //Показать максимальную калорийность;
        public float MaxCalory()
        {
            float maxCal = 0;
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select max(Calory) from FruitsVegs";
                object maxCalory = command.ExecuteScalar();
                maxCal = (float)maxCalory;
            }
            finally
            {
                connection.Close();
            }
            return maxCal;
        }

        // Показать минимальную калорийность;
        public float MinCalory()
        {
            float minCal = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select min(Calory) from FruitsVegs";
                object minCalory = cmd.ExecuteScalar();
                minCal = (float)minCalory;
            }
            finally
            {
                connection.Close();
            }              
            return minCal;
        }

        // Показать среднюю калорийность.
        public double AvgCalory()
        {
            double avgCal = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select avg(Calory) from FruitsVegs";
                object avgCalory = cmd.ExecuteScalar();
                avgCal = (double)avgCalory;
            }
            finally
            {
                connection.Close();
            }
            return avgCal;
        }

        // Показать количество овощей
        public int VegCount()
        {
            int vegCount = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select count(*) from FruitsVegs where Type='овощ'";
                object vegCnt = cmd.ExecuteScalar();
                vegCount = (int)vegCnt;
            }
            finally
            {
                connection.Close();
            }
            return vegCount;
        }

        // Показать количество фруктов;
        public int FruitsCount()
        {
            int frCount = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select count(*) from FruitsVegs where Type='фрукт'";
                object frCnt = cmd.ExecuteScalar();
                frCount = (int)frCnt;
            }
            finally
            {
                connection.Close();
            }
            return frCount;
        }

        // Показать количество овощей и фруктов заданного цвета;
        public int CountThisColor(string myColor)
        {
            int Count = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"select count(*) from FruitsVegs where Color = '{myColor}'";
                object Cnt = cmd.ExecuteScalar();
                Count = (int)Cnt;
            }
            finally
            {
                connection.Close();
            }
            return Count;           
        }

        // Показать количество овощей и фруктов каждого цвета;
        public List<FruitsVegs> CountAllColors()
        {
            List<FruitsVegs> list = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select count(*) as 'Count', Color from FruitsVegs group by Color";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new FruitsVegs()
                    {
                        Color = (string)rd[1] + " " + (int)rd[0]                       
                    });
                }
                rd.Close();

            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        // Показать овощи и фрукты с калорийностью ниже указанной
        public List<FruitsVegs> CaloryLessThen(double myCalory)
        {
            List<FruitsVegs> list = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"select Name, Calory from FruitsVegs where Calory<'{myCalory}'";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new FruitsVegs()
                    {
                        Name = (string)rd[0] + " " + (float)rd[1]
                    });
                }
                rd.Close();
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        // Показать овощи и фрукты с калорийностью выше указанной
        public List<FruitsVegs> CaloryMoreThen(double myCalory)
        {
            List<FruitsVegs> list = new List<FruitsVegs>();
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"select Name, Calory from FruitsVegs where Calory>'{myCalory}'";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new FruitsVegs()
                    {
                        Name = (string)rd[0] + " " + (float)rd[1]
                    });
                }
                rd.Close();
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}
