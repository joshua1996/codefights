string htmlToLuna(string html) {
//string html = "<div><img /></div>";
   string html2 = html;
            int start = 0;
            int end = 0;
            string mainTag = "";
            string answer = "";
            start = html.IndexOf('<');
            end = html.IndexOf('>');
           
        if(html.Length!=0)
        { string firstTag = html.Substring(start + 1, end - 1).ToUpper();
            for (int i = 0; i < html.Length; i++)
            {
                start = html.IndexOf('<');
                end = html.IndexOf('>');
                mainTag = html.Substring(start + 1, end - 1).ToUpper();
                if (mainTag == "DIV" || mainTag == "P" || mainTag == "B" || mainTag == "IMG")
                {
                    answer += mainTag + "([";
                    i -= 1;
                }
                else if (mainTag.StartsWith("/"))
                {
                    int last = html.IndexOf('>');
                    answer += "])";
                    if (html2.ToCharArray().ElementAt(7) != 'd')
                    {
                         if (mainTag.Substring(1).Trim() != firstTag.Trim())
                    {
                        answer += ", ";
                    }
                    else
                    {
                        if (answer.ToCharArray().ElementAt(answer.Length-4) == ',')
                        {
                            answer = answer.Remove(answer.Length - 4, 1);
                             answer = answer.Remove(answer.Length - 3, 1);
                        }
                    }
                    i -= 1;
                    mainTag = mainTag.Substring(1).Trim();
                    }
                }
                else
                {
                    mainTag = mainTag.Replace(" /", "({})").Trim();
                    answer += mainTag.Trim();
                }
                html = html.Substring(end + 1);
            }
             return answer;
        }else
        {
             return "";
        }
   
}
