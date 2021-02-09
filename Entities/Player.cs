using GameProject.Abstract;
using System;

namespace GameProject.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }

    }
}
