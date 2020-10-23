using System.ComponentModel.DataAnnotations;

namespace Test_Task
{
    class Indebtedness
    {
        [Key]
        public int Id { get; set; }
        public string SomethingOne { get; set; }
        public bool SomethingTwo { get; set; }
        public int SinAccount { get; set; }
        public int KOSGU { get; set; }
        public float StartYearAll { get; set; }
        public float StartYearLong { get; set; }
        public float StartYearOverdue { get; set; }
        public float IncreaseIndebtednessAll { get; set; }
        public float IncreaseIndebtednessNotMoney { get; set; }
        public float DecreaseIndebtednessAll { get; set; }
        public float DecreaseIndebtednessNotMoney { get; set; }
        public float EndYearAll { get; set; }
        public float EndYearLong { get; set; }
        public float EndYearOverdue { get; set; }
        public float EndYearAllPast { get; set; }
        public float EndYearLongPast { get; set; }
        public float EndYearOverduePast { get; set; }
    }
}
