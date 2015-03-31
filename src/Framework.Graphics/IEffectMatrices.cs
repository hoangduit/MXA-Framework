﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public interface IEffectMatrices {
		Matrix Projection { get; set; }
		Matrix View { get; set; }
		Matrix World { get; set; }
	}
}
