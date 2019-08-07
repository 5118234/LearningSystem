using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Song.Entities;

namespace Song.ServiceInterfaces
{
    /// <summary>
    /// ֱ������
    /// </summary>
    public interface ILive : WeiSha.Common.IBusinessInterface
    {
        #region ����
        /// <summary>
        /// ����ֱ��ƽ̨����Կ
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        void SetupKey(string accessKey, string secretKey);
        /// <summary>
        /// ����ֱ���ռ�����
        /// </summary>
        /// <param name="pace"></param>
        void SetupLiveSpace(string pace);       
        /// <summary>
        /// ���ò��ŵ�����
        /// </summary>
        /// <param name="rtmp"></param>
        /// <param name="hls"></param>
        /// <param name="hdl"></param>
        void SetupLive(string rtmp, string hls, string hdl);
        /// <summary>
        /// ��������������
        /// </summary>
        /// <param name="domain"></param>
        void SetupPublish(string domain);
        /// <summary>
        /// ����ֱ��ʱʵ��ͼ������
        /// </summary>
        /// <param name="domain"></param>
        void SetupSnapshot(string domain);
        /// <summary>
        /// ���õ㲥����
        /// </summary>
        /// <param name="domain"></param>
        void SetupVod(string domain);
        #endregion

        #region ��ȡ����
        /// <summary>
        /// ֱ��ƽ̨����Կ
        /// </summary>
        string GetAccessKey{ get; }
        /// <summary>
        /// ֱ��ƽ̨����Կ
        /// </summary>
        string GetSecretKey { get; }
        /// <summary>
        /// ֱ���ռ�����
        /// </summary>
        string GetLiveSpace { get; }
        /// <summary>
        /// rtmp������
        /// </summary>
        string GetRTMP { get; }
        /// <summary>
        /// hls��������
        /// </summary>
        string GetHLS { get; }
        /// <summary>
        /// hdl��������
        /// </summary>
        string GetHDL { get; }
        /// <summary>
        /// ����������
        /// </summary>
        string GetPublish { get; }
        /// <summary>
        /// ֱ��ʱʵ��ͼ������
        /// </summary>
        string GetSnapshot { get; }
        /// <summary>
        /// �㲥������
        /// </summary>
        string GetVod { get; }
        #endregion

        #region ����ֱ����
        ///// <summary>
        ///// ����ֱ����
        ///// </summary>
        ///// <param name="name"></param>
        //string StreamCreat(string name);
        ///// <summary>
        ///// ֱ�����б�
        ///// </summary>
        ///// <returns></returns>
        //string StreamList();
        #endregion
    }
}
