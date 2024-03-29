﻿using Binary_Project_Structur.Tests.Fake;
using Binary_Project_Structure_BLL.Services;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Project_Structur.Tests.UnitTestsBLL
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task Create_WhenTicketNull_ThenReturnExeption()
        {
            var Tickets = new IFakeRepository<Ticket>();
            var context = new IFakeUnitOfFactory();

            TicketDto TicketDto = null;

            TicketService service = new TicketService(context);
            TicketDto TicketDtoSaved = await service.Create(TicketDto);
        }

        [Test]
        public async Task Create_WhenValidTicket_ThenReturnTicket()
        {
            var Tickets = new IFakeRepository<Ticket>();
            var context = new IFakeUnitOfFactory();

            TicketDto TicketDto = new TicketDto()
            {
                Id = 154,
                Price = 10
            };

            TicketService service = new TicketService(context);
            TicketDto TicketDtoSaved = await service.Create(TicketDto);

            Assert.AreEqual(TicketDto.Price, TicketDtoSaved.Price);
            Assert.AreEqual(TicketDto.Id, TicketDtoSaved.Id);
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task Update_WhenTicketNull_ThenReturnExeption()
        {
            var Tickets = new IFakeRepository<Ticket>();
            var context = new IFakeUnitOfFactory();

            TicketDto TicketDto = null;

            TicketService service = new TicketService(context);
            TicketDto TicketDtoSaved = await service.Update(TicketDto);
        }

        [Test]
        public async Task Update_WhenValidTicket_ThenReturnTicket()
        {
            var Tickets = new IFakeRepository<Ticket>();
            var context = new IFakeUnitOfFactory();

            TicketDto TicketDto = new TicketDto()
            {
                Id = 154,
                Price = 10
            };

            TicketService service = new TicketService(context);
            TicketDto TicketDtoSaved = await service.Update(TicketDto);

            Assert.AreEqual(TicketDto.Price, TicketDtoSaved.Price);
            Assert.AreEqual(TicketDto.Id, TicketDtoSaved.Id);
        }
    }
}

