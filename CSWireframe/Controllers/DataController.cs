using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CSWireframe.Models;

namespace CSWireframe.Controllers {
    public class DataController : ApiController {
        public ViewModel Get() {
            return new ViewModel {
                RegistrationInfo = new RegistrationInfo {
                    Name = "Henry Wadsworth Longfellow",
                    Avatar = "http://placehold.it/300x300",
                    Id = "123456",
                    Phone = "(123) 456-7890",
                    Email = "bdobbs@gmail.com",
                    Profile = "http://google.com",
                    ReadScore = 2,
                    InstallDate = "4/14/2014",
                    Brokerage = "Bob's Realestate",
                    Broker = "bdobbs@gmail.com",
                    Association = "Horry County Association of Realtors",
                    BrokerageLogo = "http://placehold.it/60x60"
                },
                BasicInfo = new BasicInfo {
                    AboutMe =
    @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque iaculis nisl magna, vel consequat erat cursus in.
Donec laoreet, urna pretium pretium commodo, neque elit venenatis ligula, quis egestas lectus tellus a tellus.
Nam sed arcu tempor, vulputate orci sit amet, suscipit quam. Donec malesuada felis lobortis dapibus vestibulum.
Duis ornare lacus sed nisi consectetur consectetur. Cras hendrerit magna dolor, vel bibendum nisi feugiat sed.
Suspendisse pretium, ipsum ut ultricies sagittis, sapien massa feugiat nibh, et sodales tortor eros in justo.
Suspendisse quis condimentum ante. Pellentesque est urna, pretium ac neque sit amet, pulvinar lacinia ligula.
Sed ut hendrerit sem. Donec tempor tellus tortor, et porttitor est tempus et. Nulla ut metus enim.
Integer tortor augue, tincidunt et rhoncus eu, porta non dui. Suspendisse vitae est in nunc iaculis dignissim ut a purus.
Cras tempus sollicitudin nisl, sed dignissim sapien imperdiet ut. Nunc lobortis augue vitae rhoncus consequat.",
                    MyServices =
    @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque iaculis nisl magna, vel consequat erat cursus in.
Donec laoreet, urna pretium pretium commodo, neque elit venenatis ligula, quis egestas lectus tellus a tellus.
Nam sed arcu tempor, vulputate orci sit amet, suscipit quam. Donec malesuada felis lobortis dapibus vestibulum.
Duis ornare lacus sed nisi consectetur consectetur. Cras hendrerit magna dolor, vel bibendum nisi feugiat sed.
Suspendisse pretium, ipsum ut ultricies sagittis, sapien massa feugiat nibh, et sodales tortor eros in justo.
Suspendisse quis condimentum ante. Pellentesque est urna, pretium ac neque sit amet, pulvinar lacinia ligula.
Sed ut hendrerit sem. Donec tempor tellus tortor, et porttitor est tempus et. Nulla ut metus enim.
Integer tortor augue, tincidunt et rhoncus eu, porta non dui. Suspendisse vitae est in nunc iaculis dignissim ut a purus.
Cras tempus sollicitudin nisl, sed dignissim sapien imperdiet ut. Nunc lobortis augue vitae rhoncus consequat.",
                    Video = "http://youtu.be/baExq6xNhQ8",
                    Active = new[]{
                        new Active{
                            Name = "IDX",
                            Date = "1/1/2011"
                        },
                        new Active{
                            Name = "PE",
                            Date = "1/1/2011"
                        },
                        new Active{
                            Name = "DS",
                            Date = "1/1/2011"
                        },
                        new Active{
                            Name = "ADV",
                            Date = "1/1/2011"
                        },
                        new Active{
                            Name = "TKS",
                            Date = "1/1/2011"
                        }
                    },
                    Canceled = new[] {
                        new Canceled {
                            Name = "IDX",
                            Date = "1/1/2011"
                        },
                        new Canceled {
                            Name = "PE",
                            Date = "1/1/2011"
                        },
                        new Canceled {
                            Name = "DS",
                            Date = "1/1/2011"
                        },
                        new Canceled {
                            Name = "ADV",
                            Date = "1/1/2011"
                        },
                        new Canceled {
                            Name = "TKS",
                            Date = "1/1/2011"
                        }
                    },
                    ZipCodes = new[] {
                        12345,
                        12345,
                        12345,
                        12345
                    },
                    FbPages = new[] {
                        new FbPage {
                            FbId = 279375632076168,
                            Name = "realestateband",
                            ReadAssoc = true,
                            Profile = true,
                            Idx = true,
                            Feature = true,
                            Ds = true,
                            AccessToken = "359670320582025|f3MuxyR2OseUDVFKahQMjiTrk8Y"
                        },
                        new FbPage {
                            FbId = 109147225771421,
                            Name = "gwar",
                            ReadAssoc = true,
                            Profile = false,
                            Idx = true,
                            Feature = false,
                            Ds = true,
                            AccessToken = "359670320582025|f3MuxyR2OseUDVFKahQMjiTrk8Y"
                        }
                    }
                }
            };
        }
    }
}
