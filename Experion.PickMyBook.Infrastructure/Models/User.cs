<<<<<<< HEAD:Experion.PickMyBook.API/Models/User.cs
﻿using Experion.PickMyBook.Data;
namespace Experion.PickMyBook.API.Models
=======
﻿namespace Experion.PickMyBook.Infrastructure.Models
>>>>>>> 3e13842c7a12fbdf68cfc9c732c42397eb3a3914:Experion.PickMyBook.Infrastructure/Models/User.cs
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Borrowings> Borrowings { get; set; } = new List<Borrowings>();

    }
}
