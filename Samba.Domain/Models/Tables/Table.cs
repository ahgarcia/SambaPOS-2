﻿using System;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Tables
{
    public class Table : IEntity, IOrderable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public byte[] LastUpdateTime { get; set; }
        public string Category { get; set; }
        public int TicketId { get; set; }
        public bool IsTicketLocked { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int CornerRadius { get; set; }
        public double Angle { get; set; }
        public string HtmlContent { get; set; }
        public bool AutoRefresh { get; set; }

        public string UserString
        {
            get { return Name + " [" + Category + "]"; }
        }

        public Table()
        {
            Height = 70;
            Width = 70;
            AutoRefresh = true;
        }
    }
}
