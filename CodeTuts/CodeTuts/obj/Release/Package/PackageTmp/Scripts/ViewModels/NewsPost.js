function NewsPost(newsAuthor, newsContent)
{
    var self = this;

    self.NewsAuthor = newsAuthor;
    self.NewsContent = newsContent;
    self.Validate = function () {
        if (self.NewsAuthor.length < 1 || typeof self.NewsAuthor == "undefined")
            return "No Author";
        if (self.newsContent.length < 1 || typeof self.NewsContent == "undefined")
            return "You cannot enter an empty post";
        else
            return "Passed";
    };
}