using System.Linq;

namespace lab04alg {
    public class PathConvertor {
        private readonly string _msdosPath;

        public PathConvertor(string msdosPath) {
            _msdosPath = msdosPath;
        }

        public string Convert() {
            var withReplacedSlashes = _msdosPath.Replace("\\", "/");
            var pathWithoutDiskName = withReplacedSlashes.Split(':').Skip(1);
            return string.Join("", pathWithoutDiskName);
        }
    }
}