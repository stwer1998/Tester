using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesterCore.Model
{
    public class AccessRight
    {
        /// <summary>
        /// Id права
        /// </summary>
        [Key]
        public Guid AccessRightId { get; set; }
        /// <summary>
        /// Название права
        /// </summary>
        public string Right { get; set; }
        /// <summary>
        /// Id пользователя
        /// </summary>
        [ForeignKey("OwnerID")]
        public int UserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; set; }
    }
}
