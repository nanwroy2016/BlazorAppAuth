using System;
using System.Collections.Generic;

namespace BlazorAppAuth.DAL
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
    }
}
