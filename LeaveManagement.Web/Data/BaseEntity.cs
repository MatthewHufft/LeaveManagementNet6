﻿namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DataCreated { get; set; }
        public DateTime DataModified { get; set; }
    }
}
