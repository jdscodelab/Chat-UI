using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatUI
{
    public class ViewModel
    {

        //this list is going to be our source for Menu Items
        public List<MenuItems> ItemList
        {
            get
            {
                return new List<MenuItems>
                {
                    //I will provide path data for icons in the description so you may copy and paste them because it is very long to type all of them
                    //so copy and paste like i am doing here below
                    new MenuItems(){ PathData = "M12 2.0996094L1 12L4 12L4 21L10 21L10 14L14 14L14 21L20 21L20 12L23 12L12 2.0996094 z" },
                    new MenuItems(){ PathData = "M6,3A2,2,0,0,0,4,5L4,11A2,2,0,0,0,5.3398438,12.884766A2,2,0,0,0,6,13A2,2,0,0,0,6.0214844,13L18,15 6.0214844,17.001953A2,2,0,0,0,6,17A2,2,0,0,0,5.3378906,17.115234A2,2,0,0,0,4,19L4,25A2,2,0,0,0,6,27A2,2,0,0,0,6.9921875,26.734375L6.9941406,26.734375 27.390625,15.921875 27.392578,15.917969A1,1,0,0,0,28,15A1,1,0,0,0,27.390625,14.078125L6.9941406,3.265625A2,2,0,0,0,6,3z" },

                    //now if you remember "IsItemSelected" it is for to select the 2nd icon of our menu
                    new MenuItems(){ PathData ="M4 2C2.898438 2 2 2.898438 2 4L2 20C2 21.101563 2.898438 22 4 22L20 22C21.101563 22 22 21.101563 22 20L22 4C22 2.898438 21.101563 2 20 2 Z M 4 4L20 4L20 16L15 16C15 17.699219 13.699219 19 12 19C10.300781 19 9 17.699219 9 16L4 16 Z M 10 6L10 10L7 10L12 15L17 10L14 10L14 6Z", IsItemSelected=true},

                     new MenuItems() { PathData = "M26.90625 5C18.039063 5 14.746094 11.851563 17.28125 17.65625C16.964844 17.867188 16.457031 18.527344 16.5625 19.6875C16.773438 21.796875 17.722656 22.300781 18.25 22.40625C18.460938 24.410156 19.730469 26.746094 20.46875 27.0625C20.46875 28.433594 20.449219 29.582031 20.34375 31.0625C18.726563 35.308594 8.390625 34.324219 7.0625 41.9375C7.003906 42.269531 7.347656 43 8.03125 43L42 43C43.015625 43 42.996094 42.25 42.9375 41.90625C41.585938 34.324219 31.273438 35.304688 29.65625 31.0625C29.550781 29.476563 29.53125 28.433594 29.53125 27.0625C30.269531 26.746094 31.445313 24.304688 31.65625 22.40625C32.183594 22.40625 33.027344 21.769531 33.34375 19.65625C33.449219 18.496094 33.015625 17.761719 32.59375 17.65625C34.28125 15.546875 33.976563 6.90625 27.75 6.90625 Z M 15.15625 10C8.480469 10.113281 5.554688 15.425781 7.5625 19.96875C7.347656 20.074219 6.925781 20.632813 7.03125 21.59375C7.246094 23.304688 7.882813 23.71875 8.3125 23.71875C8.523438 25.320313 9.46875 27.117188 10 27.4375C10 28.503906 10.011719 28.472656 9.90625 29.75C9.039063 32.484375 0 32.28125 0 39C0 39 0 40 1 40L5.53125 40C7.058594 35.679688 11.210938 34.015625 14.34375 32.78125C16.070313 32.101563 17.839844 31.414063 18.375 30.5625C18.433594 29.632813 18.464844 28.84375 18.46875 27.96875C17.519531 26.882813 16.8125 25.191406 16.46875 23.75C15.65625 23.148438 14.777344 21.992188 14.5625 19.84375C14.46875 18.824219 14.683594 17.976563 15.03125 17.3125C14.238281 14.847656 14.289063 12.273438 15.15625 10 Z M 38 10C37.042969 10 35.914063 10.078125 34.84375 10.25C35.644531 12.597656 35.675781 15.402344 34.96875 17.40625C35.28125 18.09375 35.425781 18.929688 35.34375 19.84375L35.3125 19.90625L35.3125 19.96875C35.015625 21.933594 34.292969 23.128906 33.4375 23.78125C33.113281 25.132813 32.453125 26.839844 31.53125 27.9375C31.535156 28.796875 31.566406 29.570313 31.625 30.5625C32.160156 31.414063 33.933594 32.101563 35.65625 32.78125C38.785156 34.011719 42.9375 35.679688 44.46875 40L49 40C50 40 50 39.03125 50 39.03125C50.003906 31.296875 41.441406 33.128906 40.15625 29.59375C40.046875 28.414063 40.03125 28.523438 40.03125 27.34375C40.566406 27.023438 41.550781 25.222656 41.65625 23.71875C42.085938 23.71875 42.722656 23.277344 42.9375 21.5625C43.042969 20.707031 42.726563 20.074219 42.40625 19.96875C43.695313 18.253906 43.484375 11.5 38.65625 11.5Z" },
                new MenuItems() { PathData = "M12 0C10.894531 0 10 0.894531 10 2C10 2.042969 9.996094 2.082031 10 2.125C7.675781 2.429688 6 3.421875 6 6.03125C6 15.945313 1 14.035156 1 20C1 20 5.007813 21 12 21C18.992188 21 23 20 23 20C23 14.070313 18 16.003906 18 6.03125C18 3.398438 16.34375 2.421875 14 2.125C14.003906 2.082031 14 2.042969 14 2C14 0.894531 13.105469 0 12 0 Z M 9.15625 21.9375C9.550781 23.128906 10.675781 24 12 24C13.324219 24 14.449219 23.128906 14.84375 21.9375C13.960938 21.972656 13.007813 22 12 22C10.988281 22 10.042969 21.972656 9.15625 21.9375Z" },
                new MenuItems() { PathData = "M9,19C5.691406,19 3,21.691406 3,25 3,28.308594 5.691406,31 9,31 12.308594,31 15,28.308594 15,25 15,21.691406 12.308594,19 9,19z M25,19C21.691406,19 19,21.691406 19,25 19,28.308594 21.691406,31 25,31 28.308594,31 31,28.308594 31,25 31,21.691406 28.308594,19 25,19z M41,19C37.691406,19 35,21.691406 35,25 35,28.308594 37.691406,31 41,31 44.308594,31 47,28.308594 47,25 47,21.691406 44.308594,19 41,19z" },
                
                    //To add space i am adding blank item
                    new MenuItems() { ListItemHeight = 130 },

                new MenuItems() { PathData = "M9.6679688,2L9.1757812,4.5234375C8.3550224,4.8338012,7.5961042,5.2674041,6.9296875,5.8144531L4.5058594,4.9785156 2.1738281,9.0214844 4.1132812,10.707031C4.0445153,11.128986 4,11.558619 4,12 4,12.441381 4.0445153,12.871014 4.1132812,13.292969L2.1738281,14.978516 4.5058594,19.021484 6.9296875,18.185547C7.5961042,18.732596,8.3550224,19.166199,9.1757812,19.476562L9.6679688,22 14.332031,22 14.824219,19.476562C15.644978,19.166199,16.403896,18.732596,17.070312,18.185547L19.494141,19.021484 21.826172,14.978516 19.886719,13.292969C19.955485,12.871014 20,12.441381 20,12 20,11.558619 19.955485,11.128986 19.886719,10.707031L21.826172,9.0214844 19.494141,4.9785156 17.070312,5.8144531C16.403896,5.2674041,15.644978,4.8338012,14.824219,4.5234375L14.332031,2 9.6679688,2z M12,8C14.209,8 16,9.791 16,12 16,14.209 14.209,16 12,16 9.791,16 8,14.209 8,12 8,9.791 9.791,8 12,8z" }
                };
            }
        }

        //this list is going to be our source for Chat List Items
        public List<ChatListItems> ChatListItems {

            get {
                return new List<ChatListItems>
                {
                new ChatListItems(){ ContactProfilePic="/assets/logowhiteback.png", ContactName="Jd's Code Lab", LastMessageTime="10:30 PM", Availability="Online", IsRead=true, Message="Check out new video uploaded just now!", NewMsgCount="1", IsOnline=true},
                new ChatListItems() { ContactName = "Anna Dormun", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "Its seems logical that the strategy of providing!", ContactProfilePic="/assets/profile1.jpg" },
                new ChatListItems() {IsChatSelected=true, ContactName = "Tobias Williams", LastMessageTime = "06:18 am", Availability = "Offline", Message = "I remember everything mate. See you later", IsRead = false, ContactProfilePic="/assets/profile1.jpg"},
                new ChatListItems() { ContactName = "Jennifer Watkins", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false , ContactProfilePic="/assets/profile1.jpg", IsOnline=true}
                };
            }
        }

        public List<ConversationMessages> Messages
        {
            get {
                return new List<ConversationMessages>
                {
                    new ConversationMessages(){ IsAudioTrack= Visibility.Collapsed, Message="Hi Alex! What's Up?",MessageStatus ="Received", TimeStamp="Yesterday 14:26 PM" },
                    new ConversationMessages() { Message=string.Format("{0}{1}{2}", "Oh, hello! All perfectly.", Environment.NewLine, "I work, study and know this wonderful world!"), MessageStatus="Sent", TimeStamp="Yesterday 14:38 PM", IsAudioTrack= Visibility.Collapsed},
                    new ConversationMessages() { Message="01:24", MessageStatus="Received", TimeStamp="Yesterday 19:26 PM", IsAudioTrack= Visibility.Visible},
                    new ConversationMessages() { Message="I remeber everything mate. See you later", MessageStatus="Sent", TimeStamp="Today 06:18 AM", IsAudioTrack= Visibility.Collapsed}
                };
            }
        }
    }

    public class MenuItems
    {
        public string PathData { get; set; }

        public int ListItemHeight { get; set; }

        public bool IsItemSelected { get; set; }
    }

    public class ChatListItems
    {
        public bool IsChatSelected { get; set; }

        public bool IsOnline { get; set; }

        public string ContactProfilePic { get; set; }

        public string ContactName { get; set; }

        public string LastMessageTime { get; set; }

        public string Availability { get; set; }

        public bool IsRead { get; set; }

        public string Message { get; set; }

        public string NewMsgCount { get; set; }
    }

    public class ConversationMessages {

        public string MessageStatus { get; set; }

        public string TimeStamp { get; set; }

        public string Message { get; set; }

        public Visibility IsAudioTrack { get; set; }
    }
}
