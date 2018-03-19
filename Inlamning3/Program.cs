using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inlamning3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //SqlConnection myConnection = new SqlConnection("user id=sa; password=1234;server=KIARASHPC; Trusted_Connection=yes; database=airbnbtest; connection timeout=10");
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "Data Source=KIARASHPC;Initial Catalog=airbnbtest;Integrated Security=True";

            List<Accommodation> bostonAccommodations = new List<Accommodation> { };
            List<Accommodation> amsterdamAccommodations = new List<Accommodation> { };
            List<Accommodation> barcelonaAccommodations = new List<Accommodation> { };

            try
            {
                myConnection.Open();
                BostonAccommodationsObject();
                AmsterdamAccommodationsObject();
                BarcelonaAccommodationsObject();

                City Boston = new City("Boston", 100000, 20000, 40000, bostonAccommodations, bostonAccommodations.Count, 400000);
                City Amsterdam = new City("Amsterdam", 50000, 30000, 60000, amsterdamAccommodations, amsterdamAccommodations.Count, 350000);
                City Barcelona = new City("Barcelona", 300000, 15000, 70000, barcelonaAccommodations, barcelonaAccommodations.Count, 200000);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }

            List<Accommodation> BostonAccommodationsObject(){

                SqlCommand myCommandForBoston = new SqlCommand("select * from dbo.Boston", myConnection);
                SqlDataReader myReaderBos = myCommandForBoston.ExecuteReader();


                int roomId, hostId, minstay, accommodates, bedrooms, price;
                string roomType, borough, neighbourhood, lastModified;
                Int32 reviews;
                double overallSatisfaction, latitude, longitude; // bedrooms, price,

                while (myReaderBos.Read())
                {
                    roomId = (int)myReaderBos["room_id"];
                    hostId = (int)myReaderBos["host_id"];
                    roomType = myReaderBos["room_type"].ToString();
                    borough = myReaderBos["borough"].ToString(); //För borough måste ni kolla om borough är String
                    neighbourhood = myReaderBos["neighbourhood"].ToString();
                    reviews = (Int32)myReaderBos["reviews"];
                    overallSatisfaction = (double)myReaderBos["overall_satisfaction"];
                    accommodates = (int)myReaderBos["accommodates"];
                    bedrooms = Convert.ToInt32(Math.Round((double)myReaderBos["bedrooms"])); //Math.Round(
                    price = Convert.ToInt32(Math.Round((double)myReaderBos["price"])); //Math.Round(
                    int.TryParse((string)myReaderBos["minstay"], out minstay); // TryParse
                    latitude = (double)myReaderBos["overall_satisfaction"];
                    longitude = (double)myReaderBos["overall_satisfaction"];
                    lastModified = myReaderBos["last_modified"].ToString();

                    Accommodation acco = new Accommodation(roomId, hostId, roomType, borough, neighbourhood, reviews,
                        overallSatisfaction, accommodates, bedrooms, price, minstay, latitude,
                        longitude, lastModified);

                    bostonAccommodations.Add(acco);

                }

                return bostonAccommodations;

            }


            List<Accommodation> AmsterdamAccommodationsObject()
            {
                SqlCommand myCommandForAmsterdam = new SqlCommand("select * from dbo.Amsterdam", myConnection);
                SqlDataReader myReaderAms = myCommandForAmsterdam.ExecuteReader();


                int roomId, hostId, minstay, accommodates, bedrooms, price;
                string roomType, borough, neighbourhood, lastModified;
                Int32 reviews;
                double overallSatisfaction, latitude, longitude; // bedrooms, price,

                while (myReaderAms.Read())
                {
                    roomId = (int)myReaderAms["room_id"];
                    hostId = (int)myReaderAms["host_id"];
                    roomType = myReaderAms["room_type"].ToString();
                    borough = myReaderAms["borough"].ToString(); //För borough måste ni kolla om borough är String
                    neighbourhood = myReaderAms["neighbourhood"].ToString();
                    reviews = (Int32)myReaderAms["reviews"];
                    overallSatisfaction = (double)myReaderAms["overall_satisfaction"];
                    accommodates = (int)myReaderAms["accommodates"];
                    bedrooms = Convert.ToInt32(Math.Round((double)myReaderAms["bedrooms"])); //Math.Round(
                    price = Convert.ToInt32(Math.Round((double)myReaderAms["price"])); //Math.Round(
                    int.TryParse((string)myReaderAms["minstay"], out minstay); // TryParse
                    latitude = (double)myReaderAms["overall_satisfaction"];
                    longitude = (double)myReaderAms["overall_satisfaction"];
                    lastModified = myReaderAms["last_modified"].ToString();

                    Accommodation acco = new Accommodation(roomId, hostId, roomType, borough, neighbourhood, reviews,
                        overallSatisfaction, accommodates, bedrooms, price, minstay, latitude,
                        longitude, lastModified);

                    amsterdamAccommodations.Add(acco);

                }

                return amsterdamAccommodations;

            }

            List<Accommodation> BarcelonaAccommodationsObject()
            {
                SqlCommand myCommandForBarcelona = new SqlCommand("select * from dbo.Barcelona", myConnection);
                SqlDataReader myReaderBarc = myCommandForBarcelona.ExecuteReader();


                int roomId, hostId, minstay, accommodates, bedrooms, price;
                string roomType, borough, neighbourhood, lastModified;
                Int32 reviews;
                double overallSatisfaction, latitude, longitude; // bedrooms, price,

                while (myReaderBarc.Read())
                {
                    roomId = (int)myReaderBarc["room_id"];
                    hostId = (int)myReaderBarc["host_id"];
                    roomType = myReaderBarc["room_type"].ToString();
                    borough = myReaderBarc["borough"].ToString(); //För borough måste ni kolla om borough är String
                    neighbourhood = myReaderBarc["neighbourhood"].ToString();
                    reviews = (Int32)myReaderBarc["reviews"];
                    overallSatisfaction = (double)myReaderBarc["overall_satisfaction"];
                    accommodates = (int)myReaderBarc["accommodates"];
                    bedrooms = Convert.ToInt32(Math.Round((double)myReaderBarc["bedrooms"])); //Math.Round(
                    price = Convert.ToInt32(Math.Round((double)myReaderBarc["price"])); //Math.Round(
                    int.TryParse((string)myReaderBarc["minstay"], out minstay); // TryParse
                    latitude = (double)myReaderBarc["overall_satisfaction"];
                    longitude = (double)myReaderBarc["overall_satisfaction"];
                    lastModified = myReaderBarc["last_modified"].ToString();

                    Accommodation acco = new Accommodation(roomId, hostId, roomType, borough, neighbourhood, reviews,
                        overallSatisfaction, accommodates, bedrooms, price, minstay, latitude,
                        longitude, lastModified);

                    barcelonaAccommodations.Add(acco);

                }

                return barcelonaAccommodations;

            }
        }
    }
}







