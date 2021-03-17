﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class SeedDataTime
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            //just do this lol
            SignUpDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<SignUpDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.TimeSlots.Any())
            {
                context.TimeSlots.AddRange(

                    //each time slot has a specific time id that is generated by asp.net

                    new TimeSlots
                    {
                        Time = "8:00 am",
                        IsAvailable = true,
                        Day = "Monday"
                    },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Monday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Monday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Monday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Monday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Monday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Monday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Monday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Monday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Monday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Monday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Monday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Monday"
                                },
                               //start of tuesday
                               new TimeSlots
                               {
                                   Time = "8:00 am",
                                   IsAvailable = true,
                                   Day = "Tuesday"
                               },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Tuesday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Tuesday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Tuesday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Tuesday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Tuesday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Tuesday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Tuesday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Tuesday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Tuesday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Tuesday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Tuesday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Tuesday"
                                },
                                //start of wednesday
                                new TimeSlots
                                {
                                    Time = "8:00 am",
                                    IsAvailable = true,
                                    Day = "Wednesday"
                                },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Wednesday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Wednesday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Wednesday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Wednesday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Wednesday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Wednesday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Wednesday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Wednesday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Wednesday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Wednesday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Wednesday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Wednesday"
                                },
                                //thursday
                                new TimeSlots
                                {
                                    Time = "8:00 am",
                                    IsAvailable = true,
                                    Day = "Thursday"
                                },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Thursday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Thursday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Thursday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Thursday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Thursday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Thursday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Thursday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Thursday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Thursday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Thursday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Thursday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Thursday"
                                },
                                //friday
                                new TimeSlots
                                {
                                    Time = "8:00 am",
                                    IsAvailable = true,
                                    Day = "Friday"
                                },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Friday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Friday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Friday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Friday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Friday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Friday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Friday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Friday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Friday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Friday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Friday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Friday"
                                },
                                //saturday
                                new TimeSlots
                                {
                                    Time = "8:00 am",
                                    IsAvailable = true,
                                    Day = "Saturday"
                                },

                     new TimeSlots
                     {
                         Time = "9:00 am",
                         IsAvailable = true,
                         Day = "Saturday"
                     },

                      new TimeSlots
                      {
                          Time = "10:00 am",
                          IsAvailable = true,
                          Day = "Saturday"
                      },

                       new TimeSlots
                       {
                           Time = "11:00 am",
                           IsAvailable = true,
                           Day = "Saturday"
                       },

                        new TimeSlots
                        {
                            Time = "12:00 pm",
                            IsAvailable = true,
                            Day = "Saturday"
                        },

                         new TimeSlots
                         {
                             Time = "1:00 pm",
                             IsAvailable = true,
                             Day = "Saturday"
                         },

                          new TimeSlots
                          {
                              Time = "2:00 pm",
                              IsAvailable = true,
                              Day = "Saturday"
                          },

                           new TimeSlots
                           {
                               Time = "3:00 pm",
                               IsAvailable = true,
                               Day = "Saturday"
                           },

                            new TimeSlots
                            {
                                Time = "4:00 pm",
                                IsAvailable = true,
                                Day = "Saturday"
                            },

                             new TimeSlots
                             {
                                 Time = "5:00 pm",
                                 IsAvailable = true,
                                 Day = "Saturday"
                             },

                              new TimeSlots
                              {
                                  Time = "6:00 pm",
                                  IsAvailable = true,
                                  Day = "Saturday"
                              },

                               new TimeSlots
                               {
                                   Time = "7:00 pm",
                                   IsAvailable = true,
                                   Day = "Saturday"
                               },

                                new TimeSlots
                                {
                                    Time = "8:00 pm",
                                    IsAvailable = true,
                                    Day = "Saturday"
                                }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
