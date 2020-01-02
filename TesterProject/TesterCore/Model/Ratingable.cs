using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore.Model
{
    public abstract class Ratingable
    {
        /// <summary>
        /// Среднее значение
        /// </summary>
        public double Average { get;private set; }
        /// <summary>
        /// Все баллы которое собрал
        /// </summary>
        public int AllPoint { get;private set; }
        /// <summary>
        /// Кол-во голосовавщих
        /// </summary>
        public int RatersCount { get;private set; }
        /// <summary>
        /// Подсчитывает срю значение
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(int point) 
        {
            AllPoint += point;
            RatersCount++;
            Average = AllPoint / RatersCount;
        }
    }
}
