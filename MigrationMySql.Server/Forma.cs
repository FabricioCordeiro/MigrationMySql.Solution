﻿using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Forma
    {
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        public Guid Rowguid { get; set; }
    }
}
