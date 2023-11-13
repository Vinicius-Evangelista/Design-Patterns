using FeedNotifier.Observer;
using FeedNotifier.Subject;

var notifier = new Notifier();

var vinicius = new User(notifier,"Vinicius");
var mariana = new User(notifier, "Mariana");

vinicius.AddFollower(mariana);

vinicius.Comment("That's so cool");
vinicius.Like();
vinicius.Post("I've made my first post");
