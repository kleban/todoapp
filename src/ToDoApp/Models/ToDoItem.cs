using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле НАЗВА не можу бути пустим")]
        [MinLength(5, ErrorMessage = "Введіть мінімум 5 символів")]
        [Display(Name = "Назва задачі")]
        public string Text { get; set; }

        [Display(Name = "Статус")]
        public bool IsComplete { get; set; }

        [Display(Name = "Дата виконання")]
        public DateTime CompleteDate { get; set; }
    }
}
