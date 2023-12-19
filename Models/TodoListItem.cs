using System;
using System.ComponentModel.DataAnnotations;

namespace todo_list.Models
{
    public class TodoListItem
        {
        public int Id { get; set; }
    
        public DateTime DueDate { get; set; }

        [MaxLength(200, ErrorMessage = "Name must contain a maximum of 200 characters!")]    
        public required string Name { get; set; }       

        public bool Status { get; set; }
    }
}