﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISPCore.Application.AttendanceType.Command;
using ISPCore.Application.AttendanceType.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISPCore.API.Controllers
{
    public class AttendanceTypeController : BaseController
    {
        #region Queries

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await Mediator.Send(new Queries.GetAttendanceTypeList());
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await Mediator.Send(new Queries.GetAttendanceType { Id = id });
            return Ok(data);
        }

        #endregion

        #region Commands

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Commands.AttendanceType.Create command)
        {
            var data = await Mediator.Send(command);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Commands.AttendanceType.Update command)
        {
            var data = await Mediator.Send(command);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Commands.AttendanceType.MarkAsDelete command)
        {
            var data = await Mediator.Send(command);
            return Ok(data);
        }

        #endregion
    }
}