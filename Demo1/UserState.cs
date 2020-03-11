using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    public enum UserState
    {
        /// <summary>
        /// 正常
        /// </summary>
        [RemarkAttribute("正常")]
        Normal = 0,
        /// <summary>
        /// 已冻结
        /// </summary>
        [RemarkAttribute("已冻结")]
        Frozen = 1,
        /// <summary>
        /// 已删除
        /// </summary>
        [RemarkAttribute("已删除")]
        Deleted = 2
    }
}
