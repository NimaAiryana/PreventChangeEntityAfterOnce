#nullable disable

using PreventChangeEntityAfterOnce.Abstractions;
using PreventChangeEntityAfterOnce.EntitiesStates.CommentEntityStates;

namespace PreventChangeEntityAfterOnce.Entities
{
    public class Comment
    {
        public ICommentState BeforeChangesState => new CommentBeforeChangesState(this);
        public ICommentState ChangedState => new CommentChangedState(this);

        private ICommentState currentState;

        private Comment()
        {
            currentState = BeforeChangesState;
        }

        private Comment(string body, int creatorUserId) : this()
        {
            Body = body;
            CreatorUserId = creatorUserId;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public int CreatorUserId { get; set; }

        public void ChangeState(ICommentState commentState)
        {
            currentState = commentState;
        }

        public static Comment CreateInstance(string body, int creatorUserId)
        {
            return new(body, creatorUserId);
        }

        public void Modify(string body)
        {
            currentState.Modify(body);
        }

        public void Modify2(string body)
        {
            currentState.Modify2(body);
        }

        public void Modify3(string body)
        {
            currentState.Modify3(body);
        }

        // and other modifications methods :D ...
    }
}
