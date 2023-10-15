using InfinityComment;

var comment = new Comment("I Agree, that's so true");

var subComment1 = new Comment("I completely desagree dude!");

var subSubComment1 = new Comment("No, you don't know nothing.");

var subComment2 = new Comment("How do you know that's true?");

var subSubComment2 = new Comment("Why you are asking him?");

subComment1.AddComment(subSubComment1);
comment.AddComment(subComment1);

subComment2.AddComment(subSubComment2);
comment.AddComment(subComment2);

comment.ListComments(2);