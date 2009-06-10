namespace WikiNotes
{
    class WikiWord
    {
        public int StartingPosition { get; set; }

        public string Word { get; set; }

        public int Length { get { return Word.Length; } }

        public int EndingPosition { get { return StartingPosition + Length; } }
    }
}
