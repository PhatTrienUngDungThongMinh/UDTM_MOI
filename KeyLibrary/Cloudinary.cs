using System;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace KeyLibrary
{
    public class CloudinaryService
    {
        private readonly string ApiSecret = "iI8hy9yP-PCNgFOaTj4GXmSbkkg";
        private readonly string CloudName = "UDTM";
        private readonly string ApiKey = "994788921519568";

        private readonly Cloudinary _cloudinary;

        public CloudinaryService()
        {
            Account account = new Account(CloudName, ApiKey, ApiSecret);
            _cloudinary = new Cloudinary(account);
        }
        public string UploadImg(string filePath, string folderName = null)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("File path is required.", nameof(filePath));

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(filePath),
                Folder = folderName,
                UseFilename = true,
                UniqueFilename = true,
                Overwrite = false
            };

            var uploadResult = _cloudinary.Upload(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Trả về URL của ảnh
                return uploadResult.Url.ToString();
            }
            else
            {
                throw new Exception($"Upload failed: {uploadResult.Error?.Message}");
            }
        }
        public bool DeleteImg(string publicId)
        {
            if (string.IsNullOrEmpty(publicId))
                throw new ArgumentException("Public ID is required.", nameof(publicId));

            var deletionParams = new DeletionParams(publicId);
            var deletionResult = _cloudinary.Destroy(deletionParams);

            // Nếu xóa thành công, result sẽ là "ok"
            return deletionResult.Result == "ok";
        }
    }
}
