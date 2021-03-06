﻿using System.Collections.Generic;

namespace Bsuir.Misoi.Core.Images.Implementation
{
    public class FindInImageAndHandleResultProcessor : IImageProcessor
    {
        private readonly IFindAlgoritm _findAlgoritm;
        private readonly IFindResultsHandler _findResultsHandler;

        public FindInImageAndHandleResultProcessor(IFindAlgoritm findAlgoritm, IFindResultsHandler findResultsHandler)
        {
            _findAlgoritm = findAlgoritm;
            _findResultsHandler = findResultsHandler;
        }

        public string Name => _findAlgoritm.Name;

        public void ProcessImage(IImage image)
        {
            var imageClone = image.Clone();
            IEnumerable<IFindResult> findResult = _findAlgoritm.Find(imageClone);
            _findResultsHandler.HandleFindResults(image, findResult);
        }
    }
}
