namespace pagination.Models
{
    public class TodoModel
    {
        
        public int Id{ get; set; }
        public  required string Title { get; set; }
        public  required string Description { get; set; }
        public bool Iscompleted { get; set; } = false;
    }
}


