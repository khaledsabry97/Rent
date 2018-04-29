using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller() => dbMan = new DBManager();

        #region Image
        //to save image in the database
        public int saveimage(byte[] img,string filename,string person_id,string apartmentid)
        {
            string sql = "insert into images values("+person_id+","+apartmentid+",'" + filename + "',@img)";
            return dbMan.ExecuteNonQueryImage(sql,img);
        }

        public int saveOtherImage(byte[] img, string filename)
        {
            string sql = "insert into Other values('" + filename + "',@img)";
            return dbMan.ExecuteNonQueryImage(sql, img);
        }

        //to delete image from the database
        public int Delete_Image(string filename, string person_id, string apartmentid)
        {
            string query;
            if (person_id != "NULL")
                query = "delete from Images where person_id = " + person_id + " and File_Name = '" + filename + "'";
            else
                query = "delete from Images where Apartment_id = " + apartmentid + "  and File_Name = '" + filename + "'";

            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int Delete_Other_Image(string filename)
        {
            string query = "delete from other where File_Name = '" + filename + "'";

            return (int)dbMan.ExecuteNonQuery(query);
        }

        //get the image from the database and converte it to byte
        public byte[] getimage(string where)
        {
            string query = "select IMAGE_id from Images where "+ where;
            return (byte[]) dbMan.ExecuteScalarImage(query);
        }

        public byte[] getOtherimage(string where)
        {
            string query = "select IMAGE_id from other where " + where;
            return (byte[])dbMan.ExecuteScalarImage(query);
        }

        //to update the image in the database
        public int Editimage(byte[] img, string filename, string person_id, string apartmentid)
        {
            string query;
            if (person_id != "NULL")
                query = "update Images set Image_id = @img where person_id = " + person_id + "  and File_Name = '" + filename + "'";
            else
                query = "update Images set Image_id = @img where Apartment_id = " + apartmentid + "  and File_Name = '" + filename + "'";


            if ( (int)dbMan.ExecuteNonQueryImage(query, img) !=0)
                return 1;
          return   (int)saveimage(img, filename, person_id, apartmentid);
        }

        public int EditOtherImage(byte[] img, string filename)
        {
            string query;
                query = "update Other set Image_Id = @img where File_Name = '" + filename + "'";

            if ((int)dbMan.ExecuteNonQueryImage(query, img) != 0)
                return 1;
            return (int)saveOtherImage(img, filename);
        }
        #endregion

        #region Get Value

        //get value without determining the where condition
        public int getvalueunspecified(string select, string from)
        {
            string query = "select " + select + " from " + from;
            return (int)dbMan.ExecuteScalar(query);
        }

        //get a data column or more
        public DataTable getdatacolumn(string select, string from,string where = null)
        {
            string query = "select " + select + " from " + from;
            if(where != null)
           query += " where " + where;
            return (DataTable) dbMan.ExecuteReader(query);
        }
        
        //get integar value
        public int getvalue(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            if (dbMan.ExecuteScalar(query) == null)
                return 0;
            else
            return (int)dbMan.ExecuteScalar(query);
        }
        
        public int CheckFound(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            return dbMan.ExecuteNonQuery(query);
        }
        
        //get float value
        public double getfloat(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            return (double)dbMan.ExecuteScalar(query);
        }

        //get string value
        public String getstring(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            if (dbMan.ExecuteScalar(query) == null)
                return "";
            return dbMan.ExecuteScalar(query).ToString();


        }

        //get char value
        public char getchar(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            return (char)dbMan.ExecuteScalar(query);
        }

        //get date time value
        public DateTime GetDate(string select, string from, string where)
        {
            string query = "select " + select + " from " + from + " where " + where;
            return (DateTime)dbMan.ExecuteScalar(query);
        }

        //get the people who should Renew the contract
        public DataTable show_Renew_People(string Date)
        {
            string query = "select p.name as اسم,a.name as عقار,p.End_Date as 'تاريخ الإنتهاء',p.Rental_Price as 'قيمة الإيجار الحالي',p.Increasing_Percentage as 'نسبة الزيادة' from person p ,apartment a where p.id = a.person_id and p.end_date like '" + Date + "%'";
            return dbMan.ExecuteReader(query);
        }


        //get all information
        public DataTable get_All_Information()
        {
            string query = "SELECT  a.Name,p.name, p.Rental_Price, p.Start_Date, p.End_Date, p.Increasing_Percentage, p.Increasing_Date,p.phone, p.Insurance, p.Services, electricity_account_no, electricity_counter_no, Water_Account_No, Water_Counter_No, Gas_Account_No, Gas_Counter_No, p.Address, p.Email, p.Description FROM dbo.Apartment a,person p where p.id = a.person_id";
            return dbMan.ExecuteReader(query);
        }

        //get all the blocks where it's empty
        public DataTable get_blocks_empty()
        {
            string query = "SELECT Name FROM dbo.Apartment where Person_ID is null";
            return dbMan.ExecuteReader(query);
        }

        //get all the blocks where it's empty
        public DataTable get_blocks_busy()
        {
            string query = "SELECT Name FROM dbo.Apartment where Person_ID is not null";
            return dbMan.ExecuteReader(query);
        }

        //get all the blocks
        public DataTable get_blocks()
        {
            string query = "SELECT Name FROM dbo.Apartment";
            return dbMan.ExecuteReader(query);
        }
        #endregion

        #region Insertion & Update & Deletion

        //Insert Value without condition
        public void Insert_value(string into, string values)
        {
            string query = "insert into " + into + " values(" + values + ")";
            dbMan.ExecuteScalar(query);
        }

        //Insert Block
        public int Add_apartment(string name,string elec_account,string elec_counter,string water_account,string water_counter,string Gas_account,string Gas_counter,char kind)
        {
            string query = "insert into apartment values ('" + name + "',null,"+ elec_account+","+ elec_counter + "," + water_account + ","+ water_counter + "," + Gas_account + "," + Gas_counter + ",'"+kind+"')";
            return dbMan.ExecuteNonQuery(query);
        }
   
        //Update Block
        public int Edit_apartment(int id, string name, string elec_account, string elec_counter, string water_account, string water_counter, string Gas_account, string Gas_counter, char kind)
        {
            string query = "update apartment set ";
            query += "name ='" + name + "'";
            query += ",electricity_account_no =" + elec_account + "";
            query += ",electricity_counter_no =" + elec_counter + "";
            query += ",Water_Account_No =" + water_account + "";
            query += ",Water_Counter_No =" + water_counter + "";
            query += ",Gas_Account_No =" + Gas_account + "";
            query += ",Gas_Counter_No =" + Gas_counter + "";
            query += ",Kind ='" + kind + "'";
            query += " where id = " + id ;
            return (int)dbMan.ExecuteNonQuery(query);
        }

        //Delete Block
        public int Delete_apartment(int id)
        {
            string query = "delete from apartment where id = "+id;
            if (dbMan.ExecuteNonQuery(query)==0)
                return 0;
            query = "delete from images where Apartment_id = " + id;
           dbMan.ExecuteNonQuery(query);
            return 1;
        }

        //Insert Person
        public int Sign_Contract(string Person, string Apartment, string startdate, string enddate, string address, string comment, float rentcost, int increasingpercentage,string increasingdate, float insurance,string services, string phone, string email)
        {
            if (phone != "NULL")
                phone = "'" + phone + "'";
            string query = "insert into person values ('" + Person + "'," + phone + ",'" + startdate + "','" + enddate + "'," + rentcost + "," + increasingpercentage + ",'"+increasingdate+"'," + insurance +","+services+ "," + address + "," + email + "," + comment + ")";
            int c = (int)dbMan.ExecuteNonQuery(query);
            if (c == 0)
                return 0;

            int id = getvalueunspecified("max(id)", "person");
            query = "update apartment set person_id = " + id + " where Name = '" + Apartment + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        //Edit Person Contract
        public int Edit_Contract(int id_person, string Person, string Apartment, string startdate, string enddate, string address, string comment, float rentcost, int increasingpercentage, string increasingdate, float insurance, string services, string phone, string email)
        {
            if (phone != "NULL")
                phone = "'" + phone + "'";

            string query = "update person set ";
            query += "name ='" + Person + "'";
            query += ",phone =" + phone + "";
            query += ",Start_Date ='" + startdate + "'";
            query += ",End_Date ='" + enddate + "'";
            query += ",Rental_Price =" + rentcost + "";
            query += ",Increasing_Percentage =" + increasingpercentage + "";
            query += ",Increasing_Date ='" + increasingdate + "'";
            query += ",Address =" + address + "";
            query += ",Email =" + email + "";
            query += ",Description =" + comment + "";
            query += ",Insurance =" + insurance + "";
            query += ",Services =" + services + "";
            query += " where id = " + id_person;
            return (int)dbMan.ExecuteNonQuery(query);
        }

        //Renew Person Contract
        public int Renew_Contract(string Person, string startdate, string enddate, string comment, float rentcost, int increasingpercentage,string increasingdate, float insurance,string services)
        {
            int id = getvalue("p.id", "person p,apartment a", "p.id = a.person_id and p.name = '" + Person + "'");
            string phone = getstring("phone", "person", "id = " + id);
            string address = getstring("address", "person", "id = " + id);
            string email = getstring("email", "person", "id = " + id);
            string apartment = getstring("a.name", "person p,apartment a", "p.id = a.person_id and p.id = "+id);
            if (phone == "")
                phone = "NULL";
            if (address == "")
                address = "NULL";
            else
                address = "'" + address + "'";
            if (email == "")
                email = "NULL";
            else
                email = "'" + email + "'";

          return  Edit_Contract(id, Person, apartment, startdate, enddate, address, comment, rentcost, increasingpercentage, increasingdate, insurance, services, phone, email);
        }

        //Break Person Contract
        public int Break_Contract(string name)
        {
             int id = getvalue("p.id", "person p,apartment a", "p.id = a.person_id and p.name = '" + name + "'");

             string query = "update apartment set person_id = null where person_id = " + id;
             return dbMan.ExecuteNonQuery(query);

        }


        public int Update_Payments(string apartment_name,string comment,int month,int year,float electricity,float water,float service)
        {
            int id = getvalue("person_id", "apartment", "name ='" + apartment_name + "'");

            string query = "update paying set ";
            if (electricity != -1)
                query += " Electricity_Cost = " + electricity;
            if (water != -1)
                query += ", Water_Cost = " + water;
            if (service != -1)
                query += ", Services = " + service;
            if(comment != "null")
                query += ", Description = " + comment;

            query += " where Person_ID = " + id + " and Month = " + month +" and year = "+year;
            return dbMan.ExecuteNonQuery(query);

        }

        #endregion

        #region Functions

        //to fill the fields with null values with NULL in the database
        public string unrequired_Fields(string name)
        {
            if (name == "")
                name = "NULL";
            return name;

        }
        
        //it auto increament the months in the paying table
        public void Auto_Month_Increament()
        {
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;
            List<int> list = new List<int>();
             DataTable d = getdatacolumn("person_id", "apartment","person_id is not null");
            if (d == null)
                return;
            for (int i = 0; i < d.Rows.Count; i++)
            {
                list.Add((int)d.Rows[i]["Person_id"]);
            }

            for(int i =0; i< list.Count;i++)
            {
                if (getvalue("count(*)", "paying", "person_id = " + list[i].ToString() + " and month = " + month + " and year = " + year) == 0)
                {
                    Insert_value("paying", list[i].ToString() + ","+year+"," + month + ",null,null,null,null,null");
                }
            }

        }

        //it auto increament the increasing date and calculate the rental cost after the increasing
        public void Auto_Increasing_Date_Increament()
        {
            int day = DateTime.Today.Day;
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;
            string months =month.ToString();
            string days = day.ToString();
            if (month < 10)
                months = "0" + months;
            if (day < 10)
                days = "0" + day;
            int id ;
            string Increasing_Date;
            DateTime inc_date ;


            int years,moni,dayi;
            string monthd, dayd;

            do
            {
                Increasing_Date = year.ToString() + months + days;

               
                id = getvalue("p.id", "person p,apartment a", "a.person_id = p.id and p.increasing_Date <= '"+ Increasing_Date + "'");
                if (id == 0)
                    break;
                float rental_money = (float)getfloat("Rental_Price", "person", "id = " + id);
                inc_date = GetDate("Increasing_Date", "person", "id = " + id);
                float increasing_percentage = (float)getfloat("Increasing_Percentage", "person", "id = " + id);
                rental_money = (increasing_percentage + 100)/100 * rental_money;
                dayi = inc_date.Day;
                moni = inc_date.Month;
                monthd = inc_date.Month.ToString();
                dayd = inc_date.Day.ToString();
                years = inc_date.Year;
                years++;
                if (moni < 10)
                    monthd = "0" + monthd;
                if (dayi < 10)
                    dayd = "0" + dayd;
                Increasing_Date = years +"-"+ monthd+"-"+ dayd;
             string   query = "update person set Rental_Price = " + rental_money + ", Increasing_Date = '"+Increasing_Date+"' where id = " + id;
                if( dbMan.ExecuteNonQuery(query) == 0)
                {
                    MessageBox.Show("Error");
                    return;
                }
            } while (true);

        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        #endregion
    }
}
