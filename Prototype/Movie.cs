using System;

namespace Prototype
{
        public class Movie : Item {
        private String runtime;

        public String GetRuntime() {
            return runtime;
        }

        public void SetRuntime(String runtime) {
            this.runtime = runtime;
        }
    }
}
