namespace lab04alg {
    public class HTMLITagRenamer {
        private readonly string _allTheText;

        public HTMLITagRenamer(string allTheText) {
            _allTheText = allTheText;
        }

        public string RenameITag() {
            return _allTheText.Replace("<i>", "<курсив>").Replace("</i>", "<кінець курсиву>");
        }
    }
}