using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchScreen
{
    class Info
    {
        public string Code { get; set; }
        public string Hospital { get; set; }
        public string Total { get; set; }
        public string GeneralandAcute { get; set; }
        public string LearningDisabilities { get; set; }
        public string Maternity { get; set; }
        public string MentalIllness { get; set; }

        public Info(string Code, string Hospital, string Total, string GeneralandAcute, string LearningDisabilities, string Maternity, string MentalIllness)
        {
            this.Code = Code;
            this.Hospital = Hospital;
            this.Total = Total;
            this.GeneralandAcute = GeneralandAcute;
            this.LearningDisabilities = LearningDisabilities;
            this.Maternity = Maternity;
            this.MentalIllness = MentalIllness;
        }

    }
}

