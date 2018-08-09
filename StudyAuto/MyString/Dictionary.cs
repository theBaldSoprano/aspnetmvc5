using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.MyString {
    class Word {

        public string word { get; set; }

        /*public string Word {
            get {
                return this.Word;
            }
            set {
                this.Word = value.ToLower();
            }
        }*/

        public Word(string book) {
            this.word = book;
        }

        public int GetLength(int index) {
            return word.Length;
        }

        public char GetCharAt(int index) {
            char[] arr = this.word.ToCharArray();
            return arr[index];
        }

        public string ConcatTwo(string first) {
            return String.Concat(first, this.word);
        }

        public bool isIt(string sample) {
            return this.word.Equals(sample);
        }

        public int foo(string bar) {
            StringBuilder sb = new StringBuilder();
            return sb.Length;
        }


    }
}
