namespace ProductReviewMangement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
               new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Nice", isLike = true },
            new ProductReview() { ProductId = 3, UserId = 1, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 4, UserId = 2, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 5, UserId = 2, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 7, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 8, UserId = 4, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 9, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 10, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 11, UserId = 5, Rating = 2, Review = "Bad", isLike = false },
             new ProductReview() { ProductId = 12, UserId = 5, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 13, UserId = 5, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 14, UserId = 5, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 15, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 16, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 17, UserId = 6, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 18, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 19, UserId = 7, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 20, UserId = 7, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 21, UserId = 7, Rating = 4, Review = "Nice", isLike = true },
            };
            LinqOperations linqOperations = new LinqOperations();
            //linqOperations.ProductPrint(listProductReview);
            //linqOperations.PrintTopThreeRecords(listProductReview);
            //linqOperations.GetRecordsRatingsGreaterThanThree(listProductReview);
            linqOperations.GetCountOfProductId(listProductReview);
        }
    }
}
