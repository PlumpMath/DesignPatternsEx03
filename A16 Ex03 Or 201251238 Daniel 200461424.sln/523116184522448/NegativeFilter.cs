using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace _EventFullyApp
{
    public class NegativeFilter : FilterChain
    {
        FilterChain m_NextChain;

        public override void SetNextChain(FilterChain i_NextChain)
        {
            m_NextChain = i_NextChain;
        }

        public override Image ApplyFilter(Image i_ImageToFilter, String i_filter)
        {
            Image filteredImage = i_ImageToFilter;
            if (i_filter.Equals("negative"))
            {
                filteredImage = applyNegativeFilter(i_ImageToFilter);
            }
            else if (m_NextChain != null)
            {
                filteredImage = m_NextChain.ApplyFilter(i_ImageToFilter, i_filter);
            }

            return filteredImage;
        }

        private Bitmap applyNegativeFilter(Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
                {
                        new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                });


            return base.applyColorMatrix(sourceImage, colorMatrix);
        }
    }
}
