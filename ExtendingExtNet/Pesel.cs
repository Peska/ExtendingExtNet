using Ext.Net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web.UI;

[assembly: WebResource("ExtendingExtNet.Scripts.Pesel.js", "text/javascript")]

namespace ExtendingExtNet
{
    public class Pesel : TextField
    {
        public override string InstanceOf
        {
            get { return "PD.Controls.Pesel"; }
        }

        public override string XType
        {
            get { return "pesel"; }
        }

        public string AutoFilledValue
        {
            get
            {
                return this.State.Get<string>(nameof(AutoFilledValue), string.Empty);
            }
            set
            {
                this.State.Set(nameof(AutoFilledValue), value);
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;

                list.Add(nameof(AutoFilledValue), new ConfigOption(nameof(AutoFilledValue), null, null, AutoFilledValue));

                return list;
            }
        }

        protected override List<ResourceItem> Resources
        {
            get
            {
                string resource = "ExtendingExtNet.Scripts.Pesel.js";

                List<ResourceItem> baseList = base.Resources;

                baseList.Add(new ClientScriptItem(typeof(Pesel), resource, string.Empty));

                return baseList;
            }
        }

        protected override bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            string state = postCollection["_" + this.UniqueName + "_state"];

            if (!string.IsNullOrWhiteSpace(state))
            {
                JObject jObject = JObject.Parse(state);

                if (jObject.TryGetValue(nameof(AutoFilledValue), StringComparison.OrdinalIgnoreCase, out JToken jToken))
                {
                    this.SuspendScripting();
                    this.AutoFilledValue = jToken.ToString();
                    this.ResumeScripting();
                }
            }

            return base.LoadPostData(postDataKey, postCollection);
        }
    }
}