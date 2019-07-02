using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernOps.CommonLibrary
{
    public class SampleModel
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public Guid SampleID { get; set; }

        /// <summary>
        /// Name to identify model
        /// </summary>
        public string Name { get; set; }
    }
}
