using System;

namespace TesterCore.Interface
{
    public interface ITest
    {
        Guid OwnerId { get; set; }
        DateTime CreateDate { get; set; }
        Guid TestId { get; set; }
        /// <summary>
        /// Описание тетиа
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Тип теста
        /// </summary>
        TestType Testtype {get;set; }
        /// <summary>
        /// Текст вопроса
        /// </summary>
        string Question { get; set;}
    }

    public enum TestType 
    {
        TestWhithCloseAns,
        TestWhithOpenAns
    }
}
