.NET Microservices: CQRS & Event Sourcing with Kafka

What is a Command?
 A Command, is a combination of expressed inntent. In other words
 it describes an action that you want to be performed. It also 
 contains the information that is required to undertake the desired action.

 Commands are always named with a verb in the imperative mood.

 For Example: NewPostCommand, ListPostCommand, AddCommentCommand

 WHat is an Event?

 Events are objects that describe something that has occured in the application.
 A typical source of events is the aggregate.

 When something important happens in the aggregate, it will raise an event.

 Events are name with a past-particle verb.
 For example: PostCreatedEvent, PostLikedEvent, CommentAddedEvent