using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tjp_tester
{
    class CbdFac
    {

        public class Sheet {
            public char type;
            public string codeline;
            public string[] field;
            public string barcode;

            public Sheet()
            {
                type = 'A';
                field = new string[4] { "", "", "", "" };
                codeline = "";
            }
        }

        public List<string> GetCommand(string[] csv, uint zoom)
        {
            List<Sheet> book = LoadCsv(csv);
            List<string> cmds = new List<string>();
            foreach (Sheet sheet in book)
            {
                TjpNative.StartDocument();
                if (sheet.barcode != "")
                    TjpNative.LoadDocumentBarcode(sheet.barcode, 1, zoom);
                for (uint f = 0; f != 4; f++)
                    if ( sheet.field[f] != "")
                        TjpNative.LoadDocumentField(sheet.field[f], f + 1);
                const int size = 16 * 1024;
                byte[] room = new byte[size];
                TjpNative.EndDocument(sheet.type, room, size);
                string bold = Encoding.ASCII.GetString(room, 0, room.TakeWhile(l => l != '\0').Count());
                cmds.Add(string.Format("{0}{1}|{2}|\n", sheet.type, bold, sheet.codeline));

            }
            return cmds;
        }

        // csv format:
        // "A", "a12345677d t89798990o         ", "barcodefield", "field1", "field2", "field3", field4"
        private List<Sheet> LoadCsv(string[] csv)
        {
            List<Sheet> book = new List<Sheet>();
            foreach (string line in csv)
            {
                string[] csvfield = line.Split(',');
                
                string[] o = new string[10];
                for (int f = 0; f != o.Length; f++)
                    o[f] = "";
                csvfield.CopyTo(o, 0);

                if (o[0].IndexOfAny( new char[] { 'A', 'B', 'C', 'D'}) < 0)
                    continue;


                Sheet s = new Sheet();
                s.type = o[0][0];
                s.codeline = o[1];
                s.barcode = o[2];
                s.field[0] = o[3];
                s.field[1] = o[4];
                s.field[2] = o[5];
                s.field[3] = o[6];

                book.Add(s);
            }
            return book;
        }

    }
}
