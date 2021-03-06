using System;
using System.Collections.Generic;
using System.Data;

namespace day35ProductReviewManagementWithLinq
{
    public class Program
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

            Management management = new Management();//Creating Object of Management class

            //UC1
            // management.IterateProductReview(productReviewlist);
            // Management.Retrievetop3records(productReviewlist); //UC2
            // Management.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist); //UC3
            //Management.RetrieveCountOfReviewForEachProductId(productReviewlist); //UC4
            //Management.RetrieveProductIDAndReviewOfAllRecords(productReviewlist); //UC5
            //Management.SkipTopFiveRecords(productReviewlist); //UC6
            //Management.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist); //UC7
            //CreateDataTable(); //UC8
            //Management.RetrieveRecordWithTrueIsLike(); //UC9
            // Management.FindAverageRatingOfTheEachProductId();// uc10
            //Management.RetrieveRecordsWithReviewContainsNice();//UC11
            Management.RetrieveRecordsForGivenUserIdOrderByRating(); //UC12

            Console.ReadLine();
        }
        
        
    }
}
