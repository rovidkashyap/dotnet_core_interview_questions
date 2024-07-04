
const uploadChunk = async (file, start, end) => {
    const chunk = file.slice(start, end);
    const formData = new FormData();
    formData.append('file', chunk);
    formData.append('fileName', file.name);
    formData.append('start', start);
    formData.append('end', end);

    const response = await fetch('/api/upload', {
        method: 'POST',
        body: formData,
    });

    return response.ok;
};

const uploadFile = async (file) => {
    const chunkSize = 1024 * 1024; // 1 MB
    let start = 0;

    while (start < file.size) {
        const end = Math.min(start + chunkSize, file.size);
        const success = await uploadChunk(file, start, end);

        if (!success) {
            console.error('Chunk upload failed');
            return;
        }

        start = end;
    }

    console.log('File upload completed');
};

// Usage
const fileInput = document.getElementById('fileInput');
fileInput.addEventListener('change', (event) => {
    const file = event.target.files[0];
    if (file) {
        uploadFile(file);
    }
});