using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConcurrencyProject.Repositories.Models;

[Keyless]
[Table("attr")]
public partial class Attr
{
    [Column("CODE")]
    public int Code { get; set; }

    [Column("LABEL")]
    [StringLength(9)]
    [Unicode(false)]
    public string Label { get; set; } = null!;
}
