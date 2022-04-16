# Create a new branch on the repository you used for your first two assignments, and call the new branch Assignment 03
Clear out the contents of the branch, so there are no files in it from assignment 1 or 2 in the branch.
Be sure to make your commits to github branch often, so you don't lose any work along the way. There should be at least 3 useful commits made on your new github branch specifically for this assignment. 
In this assignment, you'll be creating a a chat application.
Create a new Blazor Web Assembly Application called FirstNameLastNameChat, where you replace FirstName and LastName accordingly with your own name.
Create a new razor component in the Client called Chat.
Add a link to this component in the side navigation of the Client.
Complete the tutorial for SignalR found here except have it work on your new chat razor component instead of on the index page of the Client.
Change the label on the first input box to say "Name" instead of "User", 
Add functionality to your application such that when a user has entered their name in the first input box of the chat component, when they focus on the message input, any other users connected to the server will see a message to the right of the Send button that says that users name is typing a message. The user who triggered this should not see the message next to their send button
For example, if someone entered their Name as "Andrew", and then clicked on the Message input box, all other users connected to the chat would see a message appear to the right of the send button that says something like "Andrew is typing a message...". Andrew would not see this message next to his send button.
When a user removes their focus, or blurs the input box, the message to the right of the send button should disappear on their computers.
When a user sends their message, clear their message input box so it doesn't have a value in it anymore.
Style the messages that are sent by the user to appear on the right side of the page, while messages they receive from other users appear on the left side of the page.
Wrap each message in a border and any other special CSS styles you would like, to make it look uniquely your own. You may also choose to use the unordered list or not for your message output. No two students assignments 
