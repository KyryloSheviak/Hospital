using System;

namespace Hospital.DAL.Entities
{
    public class Analysis : BaseEntities
    {
        public string AnalysisName { get; set; }
        public DateTime AnalysisDateTime { get; set; }
        public string Result { get; set; }

        public int HistoryId { get; set; }
        public virtual History History { get; set; }
    }
}
