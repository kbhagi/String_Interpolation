Before
var shareMessage = string.Format("Hey, check out {0} by {1}, I loved it!", book.Title,book.Author);

After 
var shareMessage = $"Hey, check out {book.Title} by {book.Author}, I loved it!";
