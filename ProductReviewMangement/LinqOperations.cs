using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewMangement
{
    public class LinqOperations
    {
        public void ProductPrint(List<ProductReview> listProductReview)
        {
            Console.WriteLine("Printing product reviewlist");
            //Print products
            foreach (var productReview in listProductReview)
            {
                Console.WriteLine($"ProductID: {productReview.ProductId},UserId: {productReview.UserId}Rating: {productReview.Rating},Review: {productReview.Review}");
            }
        }
        public void PrintTopThreeRecords(List<ProductReview> listProductReview)
        {
            //top 3 recors whose ratings are high
            Console.WriteLine("Print top three records");
            var result =listProductReview.OrderByDescending(x => x.Rating).Take(3).ToList();
            ProductPrint(result);
        }
        public void GetRecordsRatingsGreaterThanThree(List<ProductReview> listProductReview)
        {
            //fetch record whose rating greater than three and product id 1,4,9
            Console.WriteLine("Print record whose rating > 3 and product id are 1,4,9");
            var result = listProductReview.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId ==9)).ToList();
            ProductPrint(result);
        }
        public void GetCountOfProductId(List<ProductReview> listProductReview)
        {
            //Retrieve count of review present for each productID
            var result = listProductReview.GroupBy(x => x.ProductId).ToList();
            foreach( var productReview in result)
            {
                Console.WriteLine($"ProductId = {productReview.Key}, count of product = {productReview.Count()}");
            }
        }
        public void RetriveProductId(List<ProductReview> listProductReview)
        {
            // Retrieve only productId and review from the list for a records.
            var Result = listProductReview.Select(x => x.ProductId).ToList();
            foreach (var ProductReview in Result)
            {
                Console.WriteLine(ProductReview);
            }
        }
        public void SkipTop5Records(List<ProductReview> listProductReview)
        {
            // skip top 5 records from the list using LINQ and display other records
            Console.WriteLine("records after skip top 5 records");
            var result =listProductReview.OrderByDescending(x => x.Rating).Skip(5).ToList();
            ProductPrint(result);
        }
    }
}
