﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color>  GetById(int colorId);

        IResult Add(Color color);
        IResult Updated(Color color);
        IResult Deleted(Color color);
    }
}
