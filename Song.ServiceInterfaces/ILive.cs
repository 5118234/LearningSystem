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
        string GetAccessKey();
        /// <summary>
        /// ֱ��ƽ̨����Կ
        /// </summary>
        string GetSecretKey();
        /// <summary>
        /// ֱ���ռ�����
        /// </summary>
        string GetLiveSpace();
        /// <summary>
        /// rtmp������
        /// </summary>
        string GetRTMP();
        /// <summary>
        /// hls��������
        /// </summary>
        string GetHLS();
        /// <summary>
        /// hdl��������
        /// </summary>
        string GetHDL();
        /// <summary>
        /// ����������
        /// </summary>
        string GetPublish();
        /// <summary>
        /// ֱ��ʱʵ��ͼ������
        /// </summary>
        string GetSnapshot();
        /// <summary>
        /// �㲥������
        /// </summary>
        string GetVod();
        #endregion
    }
}
