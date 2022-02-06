using System;
using System.Collections.Generic;
using System.Data;

namespace day35ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
               new ProductReview() { ProductId = 1, UserId = 1, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 2, UserId = 2, Rating = 2, Review = "Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 5, UserId = 5, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 6, UserId = 10, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 7, UserId = 6, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 8, UserId = 5, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 9, UserId = 10, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 10, UserId = 41, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 11, UserId = 5, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 13, UserId = 48, Rating = 0, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 14, UserId =41, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 15, UserId = 51, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 17, UserId = 18, Rating = 6, Review = "Excelent", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 18, UserId = 9, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 19, UserId = 10, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 20, UserId = 7, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 21, UserId = 6, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 23, UserId = 10, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 24, UserId = 8, Rating = 2, Review = "Bad", isLike = true }, //Adding Date
               new ProductReview() { ProductId = 25, UserId = 12, Rating = 3, Review = "Average", isLike = false }, //Adding Data
              
            };
            //CreateDataTable(); 

            Management management = new Management();  //Creating Object of Management class

            //UC1
            // management.IterateProductReview(productReviewlist);
            // Management.Retrievetop3records(productReviewlist); //UC2
            // Management.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist); //UC3
            //Management.RetrieveCountOfReviewForEachProductId(productReviewlist); //UC4
            //Management.RetrieveProductIDAndReviewOfAllRecords(productReviewlist); //UC5
            //Management.SkipTopFiveRecords(productReviewlist); //UC6
            //Management.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist); //UC7
            CreateDataTable(); //UC8
            Console.ReadLine();
        }


        public static void CreateDataTable() //create method
        {
            try
            {
                DataTable table = new DataTable(); //create table and create object
                table.Columns.Add("ProductId", typeof(Int32)); // add Columns in table
                table.Columns.Add("UserId", typeof(Int32)); // add Columns in table
                table.Columns.Add("Rating", typeof(double)); // add Columns in table
                table.Columns.Add("Review", typeof(string)); // add Columns in table
                table.Columns.Add("isLike", typeof(bool)); // add Columns in table


                table.Rows.Add(1, 1, 4, "Average", true); //Adding Data
                table.Rows.Add(1, 2, 2, "Bad", false); //Adding Data
                table.Rows.Add(3, 3, 4, "Nice", true); //Adding Data
                table.Rows.Add(4, 4, 5, "Good", false); //Adding Data
                table.Rows.Add(5, 5, 6, "Excelent", false); //Adding Data
                table.Rows.Add(6, 10, 4, "Nice", true); //Adding Data
                table.Rows.Add(7, 6, 3, "Average", true); //Adding Data
                table.Rows.Add(8, 5, 2, "Bad", true); //Adding Data
                table.Rows.Add(9, 10, 5, "Good", true); //Adding Data
                table.Rows.Add(10, 41, 6, "Excelent", false); //Adding Data
                table.Rows.Add(11, 5, 4, "Nice", false); //Adding Data
                table.Rows.Add(12, 4, 1, "Very Bad", true); //Adding Data
                table.Rows.Add(13, 48, 0, "Excelent", false); //Adding Data
                table.Rows.Add(14, 41, 3, "Average", true); //Adding Data
                table.Rows.Add(15, 51, 4, "Nice", true); //Adding Data
                table.Rows.Add(16, 8, 1, "Very Bad", false); //Adding Data
                table.Rows.Add(17, 18, 6, "Excelent", true); //Adding Data
                table.Rows.Add(18, 9, 5, "Good", true); //Adding Data
                table.Rows.Add(19, 10, 4, "Nice", false); //Adding Data
                table.Rows.Add(20, 7, 3, "Average", true); //Adding Data
                table.Rows.Add(21, 6, 2, "Bad", true); //Adding Data
                table.Rows.Add(22, 5, 1, "Very Bad", false); //Adding Data
                table.Rows.Add(23, 10, 5, "Good", false); //Adding Data
                table.Rows.Add(24, 8, 2, "Bad", true); //Adding Date
                table.Rows.Add(22, 12, 3, "Average", false); //Adding Data

                Console.WriteLine("DataTable Records");
                foreach (var list in table.AsEnumerable())
                {
                    Console.WriteLine($"ProductId:- { list.Field<int>("ProductId")}    UserId:- {list.Field<int>("UserId")}\tRating:- {list.Field<double>("Rating")}\tReview:- { list.Field<string>("Review")} \tisLike:- {list.Field<bool>("isLike")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
