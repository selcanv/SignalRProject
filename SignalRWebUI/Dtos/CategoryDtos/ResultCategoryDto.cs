namespace SignalRWebUI.Dtos.CategoryDtos
{
	public class ResultCategoryDto
	{
		//bizim ilk başta yazdığımız dtolar sadece api için çalışıyordu
		//şimdi yazacağım dtolar json dan gelen data ile buradan göndereceğim proportyleri eşleştirecek
		//burası için UI için çalışacak

		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public bool Status { get; set; }

	}
}
