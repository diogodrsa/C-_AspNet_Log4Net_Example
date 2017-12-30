using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteLog4Net
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlConfigurator.Configure();
            ILog logger = log4net.LogManager.GetLogger(typeof(_Default));

            logger.Debug("Debug message");
            logger.Info("Info message");
            logger.Warn("Warning message");
            logger.Error("Error message");
            logger.Fatal("Fatal message");
        }
    }
}