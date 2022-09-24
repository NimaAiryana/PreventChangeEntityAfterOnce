using PreventChangeEntityAfterOnce.Entities;

var comment = Comment.CreateInstance("Nima", 1);
ShowComment(comment);

comment.Modify("Body Changed");
ShowComment(comment);

comment.Modify("Again body changed");
ShowComment(comment);

comment.Modify2("Modify2");
ShowComment(comment);

comment.Modify3("Modify3");
ShowComment(comment);

var anotherComment = Comment.CreateInstance("Another comment", 2);
ShowComment(anotherComment);

anotherComment.Modify3("Another comment body change to Modify3");
ShowComment(anotherComment);

anotherComment.Modify2("Modify2");
ShowComment(anotherComment);

static void ShowComment(Comment comment)
{
    Console.WriteLine($"creator : {comment.CreatorUserId}, body : {comment.Body} \n\r");
}
