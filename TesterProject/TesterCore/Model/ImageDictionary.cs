using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesterCore.Model
{
    public class ImageDictionary
    {
        /// <summary>
        /// Ключ файла
        /// </summary>
        [Key]
        public Guid ImageId { get; set; }
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path { get; set; }
    }
}
