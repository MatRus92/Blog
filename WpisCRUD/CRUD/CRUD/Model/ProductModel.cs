using System.ComponentModel.DataAnnotations;

namespace CRUD.Model
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Count { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProduceDate { get; set; }

        public bool Active { get; set; } 
    }
}
