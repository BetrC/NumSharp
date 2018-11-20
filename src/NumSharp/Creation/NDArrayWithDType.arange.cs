﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;

namespace NumSharp
{
    public partial class NDArrayWithDType
    {
        public NDArrayWithDType arange(int stop, int start = 0, int step = 1, Type dtype = null)
        {
            var list = new int[(int)Math.Ceiling((stop - start + 0.0) / step)];
            int index = 0;

            if(dtype == null)
            {
                dtype = typeof(int);
            }

            switch (dtype.Name)
            {
                case "Int32": 
                    storageForInt32 = new int[list.Length];
                    for (int i = start; i < stop; i += step)
                        storageForInt32[index++] = i;
                    break;

                    /*case "double": 

                        for (int i = start; i < stop; i += step)
                                storageForInt32[index++] = i + 0.0;
                        break;

                    case double[] dataArray : 
                    {
                        for(int idx = 0; idx < dataArray.Length;idx++)
                            dataArray[idx] = list[idx];
                        break;
                    }
                    case float[] dataArray : 
                    {
                        for(int idx = 0; idx < dataArray.Length;idx++)
                            dataArray[idx] = list[idx];
                        break;
                    }
                    case Complex[] dataArray : 
                    {
                        // no performance critial operation
                        dataArray = list.Select(x => (Complex) x ).ToArray();
                        break;
                    }
                    case Quaternion[] dataArray : 
                    {
                        // no performance critial operation
                        dataArray = list.Select(x => new Quaternion(new Vector3(0,0,0),x) ).ToArray();
                        break;
                    }
                    default : 
                    {
                        throw new Exception("This method was not yet implemented for this type" + typeof(T).Name);
                    }*/
            }

            this.Shape = new Shape(list.Length);

            return this;
        }
    }
}
