using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Shop1;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace Book_Shop1
{
    internal class Book1
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }

        public int NumberOfPages { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Book1()
        {
            ID = 0;
            Title = "";
            Author = "";
            Publisher = "";
            Genre = "";
            NumberOfPages = 0;
            Price = 0;
            Description = "";
        }

        public Book1(int ID, string Title , string Author , string Publisher, string Genre, int NumberOfPages, int Price, string Description)
        {
            this.ID = ID;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Genre = Genre;
            this.NumberOfPages = NumberOfPages;
            this.Price = Price;
            this.Description = Description;
        }

        public List<Book1> getAllBook1()
        {

            List<Book1> lstBook1 = new List<Book1>();



            MySqlDataReader dr = DB.getData("SELECT * FROM book_information_1");
            while (dr.Read())
            {
                lstBook1.Add(new Book1 ((int)dr["ID"], dr["Title"].ToString() ?? string.Empty, dr["Author"].ToString() ?? string.Empty,dr["Publisher"].ToString() ?? string.Empty, dr["Genre"].ToString() ?? string.Empty, (int)dr["NumberOfpages"], (int)dr["Price"], dr["Description"].ToString() ?? string.Empty));
            }

            return lstBook1;
        }

        public void addBook1(string Title, string Author, string Publisher, string Genre, int NumberOfPages, int Price, string Description)
        {
            string sqlQuery = $@"INSERT INTO `Book1`.`book_information_1` ( `Title`, `Author`, `Publisher`, `Genre`, `NumberOfPages`, `Price`, `Description`) VALUES ('{Title}', '{Author}', '{Publisher}', '{Genre}', '{NumberOfPages}', '{Price}', '{Description}');";
            DB.runCmd(sqlQuery);
        }

        public void updateBook1(int ID, string Title, string Author, string Publisher, string Genre, int NumberOfPages, int Price, string Description)
        {
            string sqlQuery = $@"INSERT INTO `Book1`.`book_information_1` SET `Title` = '{Title}', `Author` = '{Author}', `Publisher` = '{Publisher}', `Genre` = '{Genre}', `NumberOfPages` = '{NumberOfPages}', `Price` = '{Price}', `Description` = '{Description}' WHERE (`ID` = '{ID}');";
            DB.runCmd(sqlQuery);
        }

        public void deleteBook1(int ID)
        {
            string sqlQuery = $@"INSERT INTO `Book1`.`book_information_1` WHERE (`ID` = '{ID}');; ";
            DB.runCmd(sqlQuery);
        }
    }
}
